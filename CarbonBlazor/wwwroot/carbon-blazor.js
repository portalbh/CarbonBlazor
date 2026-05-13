export function focusFirst(selector) {
  const root = document.querySelector(selector);
  const first = getFocusable(root)[0];
  if (first) first.focus();
}

export function focusById(id) {
  const element = document.getElementById(id);
  if (element) element.focus();
}

export function setBodyScrollLock(locked) {
  document.body.classList.toggle('cb-scroll-lock', locked);
}

export function trapFocus(rootId, event) {
  if (event.key !== 'Tab') return;
  const root = document.getElementById(rootId);
  const focusable = getFocusable(root);
  if (!focusable.length) return;

  const first = focusable[0];
  const last = focusable[focusable.length - 1];
  if (event.shiftKey && document.activeElement === first) {
    event.preventDefault();
    last.focus();
  } else if (!event.shiftKey && document.activeElement === last) {
    event.preventDefault();
    first.focus();
  }
}

export function rove(rootId, nextIndex) {
  const root = document.getElementById(rootId);
  if (!root) return;
  const items = [...root.querySelectorAll('[data-roving-item]')];
  if (!items.length) return;
  items.forEach((item, index) => item.tabIndex = index === nextIndex ? 0 : -1);
  items[nextIndex]?.focus();
}

function getFocusable(root) {
  if (!root) return [];
  return [...root.querySelectorAll('a[href], button:not([disabled]), input:not([disabled]), select:not([disabled]), textarea:not([disabled]), [tabindex]:not([tabindex="-1"])')]
    .filter((element) => !element.hasAttribute('disabled') && !element.getAttribute('aria-hidden'));
}
