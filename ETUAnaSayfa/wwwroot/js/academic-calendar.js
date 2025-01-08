document.addEventListener('DOMContentLoaded', function () {
    // Dönem sekmelerini yönet
    const semesterTabs = document.querySelectorAll('.semester-tab');
    const semesterContents = document.querySelectorAll('.semester-content');

    semesterTabs.forEach(tab => {
        tab.addEventListener('click', () => {
            // Aktif sekmeyi güncelle
            semesterTabs.forEach(t => t.classList.remove('active'));
            tab.classList.add('active');

            // İlgili içeriği göster
            const semester = tab.dataset.semester;
            semesterContents.forEach(content => {
                content.classList.remove('active');
                if (content.id === semester) {
                    content.classList.add('active');
                }
            });
        });
    });
}); 