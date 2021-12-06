const github_repo = document.querySelector('.github')

fetch('https://api.github.com/users/anrouxel/repos')
.then((response) => response.json())
.then((json) => {
    for (const repo of json) {
        let github = document.createElement('div')
        github.className = "cards-list-item-outer card-aspect-ratio-landscape"

        let github_card = document.createElement('div')
        github_card.className = "cards-list-item-inner"

        let link = document.createElement('a')
        link.className = "cards-list-item-thumbnail"
        link.href = repo.html_url

        let link_svg = document.createElementNS('http://www.w3.org/2000/svg', 'svg')
        link_svg.setAttribute('class', 'bi bi-github')
        link_svg.setAttribute('viewBox', '0 0 16 16')
        link_svg.setAttribute('fill' ,'currentColor')

        let link_svg_path = document.createElementNS('http://www.w3.org/2000/svg', 'path')
        link_svg_path.setAttribute('d', 'M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27.68 0 1.36.09 2 .27 1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.012 8.012 0 0 0 16 8c0-4.42-3.58-8-8-8z')

        let github_card_item = document.createElement('div')
        github_card_item.className = "cards-list-item-info"

        let head_item = document.createElement('a')
        head_item.className = "cards-list-item-headline"
        head_item.href = repo.html_url
        head_item.textContent = "GitHub"

        let title_item = document.createElement('a')
        title_item.className = "cards-list-item-title"
        title_item.href = repo.html_url
        title_item.textContent = repo.name

        link_svg.appendChild(link_svg_path)
        link.appendChild(link_svg)
        github_card_item.appendChild(head_item)
        github_card_item.appendChild(title_item)
        github_card.appendChild(link)
        github_card.appendChild(github_card_item)
        github.appendChild(github_card)

        github_repo.appendChild(github)
    }
})