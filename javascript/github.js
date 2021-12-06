const github_repo = document.querySelector('.github')

fetch('https://api.github.com/users/anrouxel/repos')
.then((response) => response.json())
.then((json) => {
    for (const repo of json) {
        let github = document.createElement('div')
        github.className = "feature col"

        let github_icon = document.createElement('div')
        github_icon.className = "feature-icon bg-primary bg-gradient"

        let github_icon_svg = document.createElementNS('http://www.w3.org/2000/svg', 'svg')
        github_icon_svg.setAttribute('class', 'bi bi-github')
        github_icon_svg.setAttribute('width', '1em')
        github_icon_svg.setAttribute('height', '1em')
        github_icon_svg.setAttribute('viewBox', '0 0 16 16')
        github_icon_svg.setAttribute('fill' ,'currentColor')

        let github_icon_svg_path = document.createElementNS('http://www.w3.org/2000/svg', 'path')
        github_icon_svg_path.setAttribute('d', 'M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27.68 0 1.36.09 2 .27 1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.012 8.012 0 0 0 16 8c0-4.42-3.58-8-8-8z')

        github_icon_svg.appendChild(github_icon_svg_path)
        github_icon.appendChild(github_icon_svg)

        let title = document.createElement('h2')
        title.textContent = repo.name

        let text = document.createElement('p')
        text.textContent = repo.description

        let link = document.createElement('a')
        link.href = repo.html_url
        link.className = "icon-link"
        link.textContent = "En savoir plus"

        let link_svg = document.createElementNS('http://www.w3.org/2000/svg', 'svg')
        link_svg.setAttribute('class', 'bi')
        link_svg.setAttribute('width', '1em')
        link_svg.setAttribute('height', '1em')
        link_svg.setAttribute('viewBox', '0 0 16 16')
        link_svg.setAttribute('fill' ,'currentColor')


        let link_svg_path = document.createElementNS('http://www.w3.org/2000/svg', 'path')
        link_svg_path.setAttribute('d', 'M4.646 1.646a.5.5 0 0 1 .708 0l6 6a.5.5 0 0 1 0 .708l-6 6a.5.5 0 0 1-.708-.708L10.293 8 4.646 2.354a.5.5 0 0 1 0-.708z')

        link_svg.appendChild(link_svg_path)
        link.appendChild(link_svg)

        github.appendChild(github_icon)
        github.appendChild(title)
        github.appendChild(text)
        github.appendChild(link)

        github_repo.appendChild(github)
    }
})