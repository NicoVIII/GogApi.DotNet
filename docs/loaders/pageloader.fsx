#r "../_lib/Fornax.Core.dll"

type Shortcut = {
    title: string
    link: string
    icon: string
}

let loader (projectRoot: string) (siteContent: SiteContents) =
    siteContent.Add({title = "Home"; link = "https://nicoviii.github.io/GogApi.DotNet"; icon = "fas fa-home"})
    siteContent.Add({title = "GitHub repo"; link = "https://github.com/NicoVIII/GogApi.DotNet"; icon = "fab fa-github"})
    siteContent.Add({title = "License"; link = "https://github.com/NicoVIII/GogApi.DotNet/blob/master/LICENSE.md"; icon = "far fa-file-alt"})
    siteContent
