document.addEventListener("DOMContentLoaded", () => {
    const texts = ["Front-end development", "Back-end development", "Web designing", "App development"];
    let currentIndex = 0;
    let charIndex = 0;
    let isDeleting = false;
    const span = document.getElementById("dynamic-text");
    const typingSpeed = 100; // Speed of typing
    const deletingSpeed = 50; // Speed of deleting
    const pauseBetweenTexts = 2000; // Pause before starting to delete text

    function type() {
        if (charIndex < texts[currentIndex].length && !isDeleting) {
            span.textContent += texts[currentIndex].charAt(charIndex);
            charIndex++;
            setTimeout(type, typingSpeed);
        } else if (isDeleting) {
            if (charIndex > 0) {
                span.textContent = texts[currentIndex].substring(0, charIndex - 1);
                charIndex--;
                setTimeout(type, deletingSpeed);
            } else {
                isDeleting = false;
                currentIndex = (currentIndex + 1) % texts.length;
                setTimeout(type, typingSpeed);
            }
        } else {
            isDeleting = true;
            setTimeout(type, pauseBetweenTexts);
        }
    }
    setTimeout(type, typingSpeed);
});


$(document).ready(function() {
    $('#contactForm').submit(function(event) {
        event.preventDefault(); // Prevent default form submission

        var formData = $(this).serialize(); // Serialize form data
        $.ajax({
            type: 'POST',
            url: 'send_email.php',
            data: formData,
            success: function(response) {
                $('#statusMessage').html(response);
                 // Update status message div
                $('#contactForm')[0].reset();
                $('#success-submit').text('Your message has been sent successfully!').show();
                setTimeout(function() {
                    $('#success-submit').hide();
                }, 5000);
            }
        });
    });
});


