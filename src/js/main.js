const URL_profile = "https://api.github.com/users/anrouxel"
const profile = document.getElementById('profile')
const github_profile = document.getElementById('github_profile')

fetch(URL_profile).then((response) => response.json()).then((json) => {
    profile.src = json.avatar_url
    github_profile.href = json.html_url
    repositories(json.repos_url)
})

function repositories(URL_repo) {
    fetch(URL_repo).then((response) => response.json()).then((json) => {
        console.log(json)
    })
}