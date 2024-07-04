body {
    font-family: 'Lato', sans-serif;
    margin: 0;
    padding: 0;
    background-color: #2C2F33;
    color: #FFF;
}

header {
    background: url('maze-background.jpg') center/cover no-repeat, #23272A;
    color: #FFF;
    padding: 3rem 0;
    text-align: center;
    position: relative;
}

header nav {
    position: absolute;
    top: 1rem;
    right: 2rem;
}

header nav ul {
    list-style: none;
    margin: 0;
    padding: 0;
    display: flex;
}

header nav ul li {
    margin-left: 2rem;
}

header nav ul li a {
    color: #FFF;
    text-decoration: none;
    font-weight: 700;
}

header h1 {
    font-size: 3rem;
    margin: 0.5rem 0;
}

header p {
    font-size: 1.25rem;
    margin: 1rem 0 2rem;
}

.cta-button {
    display: inline-block;
    padding: 0.75rem 2rem;
    color: #FFF;
    background-color: #7289DA;
    text-decoration: none;
    border-radius: 4px;
    font-size: 1rem;
    font-weight: 700;
    transition: background-color 0.3s ease;
}

.cta-button:hover {
    background-color: #5865F2;
}

.container {
    max-width: 1200px;
    margin: 2rem auto;
    padding: 0 2rem;
}

section {
    background-color: #23272A;
    padding: 2rem;
    margin-bottom: 2rem;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
    opacity: 0;
    transform: translateY(20px);
    transition: opacity 0.6s ease, transform 0.6s ease;
}

section.visible {
    opacity: 1;
    transform: translateY(0);
}

h2 {
    font-size: 2rem;
    color: #7289DA;
    margin-bottom: 1rem;
}

p {
    line-height: 1.6;
}

.features-grid {
    display: flex;
    flex-wrap: wrap;
    gap: 2rem;
}

.feature-item {
    flex: 1 1 calc(50% - 2rem);
    background-color: #2C2F33;
    padding: 1rem;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
}

.feature-item h3 {
    margin-top: 0;
    color: #7289DA;
}

ul {
    list-style-type: none;
    padding: 0;
}

li {
    margin-bottom: 0.5rem;
    font-size: 1.1rem;
}

a {
    color: #7289DA;
    text-decoration: none;
}

a:hover {
    text-decoration: underline;
}

footer {
    background-color: #23272A;
    color: #FFF;
    text-align: center;
    padding: 1rem 0;
}

@media (max-width: 768px) {
    .features-grid {
        flex-direction: column;
    }

    header nav ul {
        flex-direction: column;
        align-items: center;
    }

    header nav ul li {
        margin-left: 0;
        margin-bottom: 1rem;
    }

    header nav ul li a {
        font-size: 1rem;
    }

    header h1 {
        font-size: 2rem;
    }

    header p {
        font-size: 1rem;
    }
}
