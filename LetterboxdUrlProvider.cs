using System;
using System.Collections.Generic;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Providers;

namespace Jellyfin.Plugin.Letterboxd
{
    public class LetterboxdUrlProvider : IExternalUrlProvider
    {
        public string Name => "Letterboxd";

        public bool Supports(BaseItem item) => item is Movie;

        public IEnumerable<string> GetExternalUrls(BaseItem item)
        {
            if (item is Movie &&
                item.ProviderIds != null &&
                item.ProviderIds.TryGetValue("Imdb", out var imdbId) &&
                !string.IsNullOrEmpty(imdbId))
            {
                yield return $"https://letterboxd.com/imdb/{imdbId}";
            }
        }
    }

    public class Plugin
    {
        public string Name => "Letterboxd Link on Movies";
        public string Description => "Adds a Letterboxd link to movie detail pages.";
        public string Version => "1.0.0.0";
        public string Creator => "zamhedonia";
        public Guid Id { get; } = new Guid("d20f95e1-8b89-7c2b-9e73-43e9f3d29f10");
    }
}
