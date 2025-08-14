window.combobox = {
    registerOutsideClick: function (dotnetRef) {
        document.addEventListener('click', function (e) {
            if (!e.target.closest('.combobox-wrapper')) {
                dotnetRef.invokeMethodAsync('CloseDropdown');
            }
        });
    }
};
