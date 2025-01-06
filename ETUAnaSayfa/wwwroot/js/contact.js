document.addEventListener('DOMContentLoaded', function () {
    const form = document.getElementById('contactForm');

    form.addEventListener('submit', function (e) {
        e.preventDefault();

        // Form doğrulama
        if (!form.checkValidity()) {
            e.stopPropagation();
            form.classList.add('was-validated');
            return;
        }

        // reCAPTCHA doğrulama
        const recaptchaResponse = grecaptcha.getResponse();
        if (!recaptchaResponse) {
            alert('Lütfen robot olmadığınızı doğrulayın.');
            return;
        }

        // Form verilerini topla
        const formData = new FormData(form);

        // AJAX ile form gönderimi
        fetch('/Home/Contact', {
            method: 'POST',
            body: formData
        })
            .then(response => response.json())
            .then(data => {
                if (data.success) {
                    alert('Mesajınız başarıyla gönderildi.');
                    form.reset();
                    grecaptcha.reset();
                } else {
                    alert('Bir hata oluştu. Lütfen tekrar deneyin.');
                }
            })
            .catch(error => {
                console.error('Error:', error);
                alert('Bir hata oluştu. Lütfen tekrar deneyin.');
            });
    });
}); 