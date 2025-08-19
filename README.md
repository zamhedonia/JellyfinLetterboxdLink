# Letterboxd Link on Jellyfin Movies

<img alt="Logo" src="https://raw.githubusercontent.com/zamhedonia/JellyfinLetterboxdLink/master/Image.png" width="400" />

A simple Jellyfin plugin that adds a **Letterboxd external link** to movie detail pages.  
The link is generated from each movie’s IMDb ID, pointing directly to its corresponding page on [Letterboxd](https://letterboxd.com).

## Features
- Adds a Letterboxd button alongside your other external links (IMDb, TMDb, etc.)
- Works only for **movies**

<img alt="Preview" src="https://raw.githubusercontent.com/zamhedonia/images/refs/heads/master/Letterboxd.png" width="400" />

## Installing from Repository (Recommended)

1. Open **Jellyfin Dashboard** → **Catalog** → **Settings Icon (⚙️)**.
2. Click **+**.
3. Enter:
   - **Repository Name:** Letterboxd Link  
   - **Repository URL:**  
     ```
     https://raw.githubusercontent.com/zamhedonia/JellyfinLetterboxdLink/master/manifest.json
     ```
4. Save, then go to the **Catalog** tab.
5. Find **Letterboxd Link on Movies** and click **Install**.
6. Restart Jellyfin.

## How to build from source

### Prerequisites

Before building this plugin from source, make sure you have:

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later, [install here](https://learn.microsoft.com/en-us/dotnet/core/install/linux)
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
  mkdir LetterboxdLinkOnMovies; cd LetterboxdLinkOnMovies; cp ~/JellyfinLetterboxdLink/bin/Release/net8.0/*.dll ./
  ```
6. Restart Jellyfin via your preferred method

Example:
   ```bash
   sudo systemctl restart jellyfin
   ```
