var currentTab = 0;

function showTab(e) {
    var t = document.getElementsByClassName("wizard-tab");
    t[e].style.display = "block",
        document.getElementById("prevBtn").style.display = 0 == e ? "none" : "inline",
        document.getElementById("nextBtn").style.display = e == t.length - 1 ? "none" : "inline",
        document.getElementById("btnSubmitWizard").style.display = e == t.length - 1 ? "inline" : "none",
        document.getElementById("btnCancel").style.display = e == 0 ? "inline" : "none",
        fixStepIndicator(e);
}

function nextPrev(e) {
    var isValid = true;
    var t = document.getElementsByClassName("wizard-tab");
    var x = t[currentTab].querySelectorAll("input, select, textarea, radio");

    if (e == 1) {
        $.each(x, function () {
            $('#myFormWizard').validate().element($(this));
            if (!$(this).valid()) {
                isValid = false;
            }
        });
    }

    if (isValid) {
        t[currentTab].style.display = "none",
            (currentTab += e) >= t.length && (t[currentTab -= e].style.display = "block"),
            showTab(currentTab);
    }
}

function fixStepIndicator(e) {
    for (var t = document.getElementsByClassName("list-item"), n = 0; n < t.length; n++) t[n].className = t[n].className.replace(" active", "");
    t[e].className += " active";
}

showTab(currentTab);