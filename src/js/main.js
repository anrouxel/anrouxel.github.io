const URL_profile = "https://api.github.com/users/anrouxel"
const profile = document.getElementById('profile')
const github_profile = document.getElementById('github_profile')
const github_repo = document.getElementById('github_repo')
const btn_logo_serre = document.getElementById("btn_logo_serre")
const btn_serre = document.getElementById("btn_serre")
let model_logo_serre = document.getElementById('model_logo_serre')
let model_serre = document.getElementById('model_serre')
var afficher = "Afficher"
var masquer = "Masquer"

model_logo_serre.style.visibility = 'hidden'
model_serre.style.visibility = 'hidden'
btn_logo_serre.textContent = afficher
btn_serre.textContent = afficher

btn_logo_serre.addEventListener("click", () => {
    if (model_logo_serre.style.visibility == 'hidden') {
        model_logo_serre.style.visibility = 'visible'
        btn_logo_serre.textContent = masquer
    } else if (model_logo_serre.style.visibility == 'visible') {
        model_logo_serre.style.visibility = 'hidden'
        btn_logo_serre.textContent = afficher
    }
})

btn_serre.addEventListener("click", () => {
    if (model_serre.style.visibility == 'hidden') {
        model_serre.style.visibility = 'visible'
        btn_serre.textContent = masquer
    } else if (model_serre.style.visibility == 'visible') {
        model_serre.style.visibility = 'hidden'
        btn_serre.textContent = afficher
    }
})

fetch(URL_profile).then((response) => response.json()).then((json) => {
    let profile_avatar = Profile(json.avatar_url)
    profile.appendChild(profile_avatar)
    github_profile.href = json.html_url
    repositories(json.repos_url)
})

function repositories(URL_repo) {
    fetch(URL_repo).then((response) => response.json()).then((json) => {
        for (const repo of json) {
            let github_main = Github_repo(repo)
            github_repo.appendChild(github_main)
        }
    })
}

function Profile(avatar) {
    let profile_avatar = document.createElement('img')
    profile_avatar.src = avatar
    profile_avatar.className = "d-block mx-lg-auto img-fluid"
    profile_avatar.loading = "lazy"
    profile_avatar.width = "700"
    profile_avatar.height = "500"
    profile_avatar.alt = "Photo de profil"
    return profile_avatar
}

function Github_repo(json) {
    let github_main = document.createElement('div')
    let github_icon = document.createElement('div')
    let icon = document.createElement('i')
    let github_content = document.createElement('div')
    let github_title = document.createElement('h2')
    let github_subtitle = document.createElement('p')
    let github_button = document.createElement('a')
    let github_contentText = document.createElement('div')
    let github_contentButton = document.createElement('div')

    github_main.className = "col d-flex align-items-start"
    github_icon.className = "icon-square bg-light text-dark flex-shrink-0 me-3"
    icon.className = "bi bi-github"
    github_button.className = "btn btn-primary"
    github_content.className = "d-flex flex-column h-100 w-100"
    github_contentText.className = "d-flex flex-column h-100"
    github_title.textContent = json.name
    github_subtitle.textContent = json.description
    github_button.href = json.html_url
    github_button.textContent = "En savoir plus"

    github_icon.appendChild(icon)
    github_contentText.appendChild(github_title)
    github_contentText.appendChild(github_subtitle)
    github_contentButton.appendChild(github_button)
    github_content.appendChild(github_contentText)
    github_content.appendChild(github_contentButton)
    github_main.appendChild(github_icon)
    github_main.appendChild(github_content)
    return github_main
}