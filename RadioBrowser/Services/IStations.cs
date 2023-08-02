using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace RadioBrowser
{
    public interface IStations
    {
        /// <summary>
        /// Get all stations.
        /// </summary>
        /// <returns>Array of the stations.</returns>
        Task<StationInfo[]> GetAllAsync();

        /// <summary>
        /// Advanced search.
        /// </summary>
        /// <param name="options">Advanced search options.</param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> AdvancedSearchAsync(AdvancedSearchOptions options);

        /// <summary>
        /// Search stations by uuid.
        /// </summary>
        /// <param name="uuid">Station uuid.</param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> SearchByUuidAsync(Guid uuid, ExtendedQueryOptions options = null);

        /// <summary>
        /// Search stations by uuids.
        /// </summary>
        /// <param name="uuids">Station uuids.</param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> SearchByUuidAsync(IEnumerable<Guid> uuids, ExtendedQueryOptions options = null);

        /// <summary>
        /// Search stations by uuids.
        /// </summary>
        /// <param name="name">Station name.</param>
        /// <param name="exact">True if only search for perfect matches. </param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> SearchByNameAsync(string name, bool exact = false, ExtendedQueryOptions options = null);

        /// <summary>
        /// Search stations with the same url.
        /// </summary>
        /// <param name="url">Station url.</param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> SearchByUrlAsync(string url, ExtendedQueryOptions options = null);



        /// <summary>
        /// Get stations that are clicked the most.
        /// </summary>
        /// <param name="limit">Optional stations limit.</param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> GetByMostClickedAsync(uint limit = 0, QueryOptions options = null);

        /// <summary>
        /// Get stations with highest votes.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> GetByMostVotedAsync(uint limit = 0, QueryOptions options = null);

        /// <summary>
        /// Get stations by recent clicks.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> GetByRecentClickAsync(uint limit = 0, QueryOptions options = null);

        /// <summary>
        /// Get recently changed stations.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> GetByLastChangesAsync(uint limit = 0, QueryOptions options = null);



        /// <summary>
        /// Increase click count. This should be called everytime when a user starts playing a stream to mark the stream more popular than others. 
        /// Every call to this endpoint from the same IP address and for the same station only gets counted once per day.
        /// </summary>
        /// <param name="uuid">Station uuid.</param>
        /// <returns>Result of action.</returns>
        Task<ClickResult> ClickAsync(Guid uuid);

        /// <summary>
        /// Vote station.
        /// </summary>
        /// <param name="uuid">Station uuid.</param>
        /// <returns>Result of action.</returns>
        Task<ActionResult> VoteAsync(Guid uuid);

        /// <summary>
        /// Add new station.
        /// </summary>
        /// <param name="newStation">New station to add.</param>
        /// <returns>Result of action.</returns>
        Task<AddStationResult> AddStationAsync(NewStation newStation);
    }
}
