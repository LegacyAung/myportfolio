document.addEventListener('DOMContentLoaded', function() {
    function isInViewport(element) {
        const rect = element.getBoundingClientRect();
        return (
            rect.top >= 0 &&
            rect.left >= 0 &&
            rect.bottom <= (window.innerHeight || document.documentElement.clientHeight) &&
            rect.right <= (window.innerWidth || document.documentElement.clientWidth)
        );
    }

    const aboutMeSection = document.getElementById('aboutme');
    const descriptionDiv = document.querySelector('.aboutme-description-div');
    const children = descriptionDiv.querySelectorAll('h2, p');

    function handleScroll() {
        if (isInViewport(aboutMeSection)) {
            children.forEach((child, index) => {
                if (!child.classList.contains('dropdown')) {
                    setTimeout(() => {
                        child.classList.add('dropdown');
                    }, index * 100); // Adjust the delay as needed
                }
            });
        }
    }

    window.addEventListener('scroll', handleScroll);
    handleScroll(); // Trigger animation on page load
});








