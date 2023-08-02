﻿using System.Threading.Tasks;

namespace RadioBrowser
{
    public interface ILists
    {
        /// <summary>
        /// Get countries.
        /// </summary>
        /// <param name="filter">If it is not null, it will only return the ones containing the filter as substring in the country code.</param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of countries.</returns>
        Task<CountryInfo[]> GetCountriesAsync(string filter = null, ExtendedQueryOptions options = null);

        /// <summary>
        /// Get codecs.
        /// </summary>
        /// <param name="filter">If it is not null, it will only return the ones containing the filter as substring in the name.</param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of codecs.</returns>
        Task<CodecInfo[]> GetCodecsAsync(string filter = null, ExtendedQueryOptions options = null);

        /// <summary>
        /// Get country states.
        /// </summary>
        /// <param name="country">If it is not null,  it will only return the states in this country.</param>
        /// <param name="filter">If it is not null, it will only return the ones containing the filter as substring in the name.</param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of country states.</returns>
        Task<StateInfo[]> GetStatesAsync(string country = null, string filter = null, ExtendedQueryOptions options = null);

        /// <summary>
        /// Get languages.
        /// </summary>
        /// <param name="filter">If it is not null, it will only return the ones containing the filter as substring in the name.</param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of languages.</returns>
        Task<LanguageInfo[]> GetLanguagesAsync(string filter = null, ExtendedQueryOptions options = null);

        /// <summary>
        /// Get tags.
        /// </summary>
        /// <param name="filter">If it is not null, it will only return the ones containing the filter as substring in the name.</param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of tags.</returns>
        Task<TagInfo[]> GetTagsAsync(string filter = null, ExtendedQueryOptions options = null);
    }
}
