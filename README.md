# Letterboxd Link on Jellyfin Movies

![Image](https://raw.githubusercontent.com/zamhedonia/JellyfinLetterboxdLink/master/Image.png)

A simple Jellyfin plugin that adds a **Letterboxd external link** to movie detail pages.  
The link is generated from each movie’s IMDb ID, pointing directly to its corresponding page on [Letterboxd](https://letterboxd.com).

## Features
- Adds a Letterboxd button alongside your other external links (IMDb, TMDb, etc.)
- Works only for **movies**

## How to build from source

### Prerequisites

Before building this plugin from source, make sure you have:

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later  
  (verify with `dotnet --version`)
- A C# build environment (Linux, macOS, or Windows)
- `git` installed to clone the repository
- A running Jellyfin server (10.8+ recommended)
 
### Building the plugin (+ Installation)

1. Clone the repository
  ```bash
  cd ~; git clone https://github.com/zamhedonia/JellyfinLetterboxdLink.git
  ```
2. Change into the project directory
  ```bash
  cd JellyfinLetterboxdLink
  ```
3. Build the plugin
  ```bash
  dotnet build -c Release
  ```
4. Move to **your plugins folder**
  ```bash
  cd /var/lib/jellyfin/plugins
  ```
  or
  ```bash
  cd ~/.local/share/jellyfin/plugins/
  ```
5. Copy over the created files
  ```bash
  mkdir LetterboxdLinkOnMovies; cp ~/JellyfinLetterboxdLink/bin/Release/net8.0/*.dll ./
  ```
6. Restart Jellyfin via your preferred method

Example:
   ```bash
   sudo systemctl restart jellyfin
   ```
