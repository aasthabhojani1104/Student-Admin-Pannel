function showAlert() {
    if (confirm('Are you sure want to delete?')) {
        return true;
    }
    return false;
}

function selectNavigation(link) {
    link.parentElement.classList.add('active');
}