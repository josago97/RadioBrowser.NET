using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadioBrowserNet
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
        Task<StationInfo[]> SearchByUuidAsync(Guid uuid, StationQueryOptions? options = null);

        /// <summary>
        /// Search stations by uuids.
        /// </summary>
        /// <param name="uuids">Station uuids.</param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> SearchByUuidAsync(IEnumerable<Guid> uuids, StationQueryOptions? options = null);

        /// <summary>
        /// Search stations by uuids.
        /// </summary>
        /// <param name="name">Station name.</param>
        /// <param name="exact">True if only search for perfect matches. </param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> SearchByNameAsync(string name, bool exact = false, StationQueryOptions? options = null);

        /// <summary>
        /// Search stations with the same url.
        /// </summary>
        /// <param name="url">Station url.</param>
        /// <param name="options">Query options.</param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> SearchByUrlAsync(string url, StationQueryOptions? options = null);



        /// <summary>
        /// Get stations that are clicked the most.
        /// </summary>
        /// <param name="limit">Optional stations limit.</param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> GetByMostClickedAsync(uint limit = 0, QueryOptions? options = null);

        /// <summary>
        /// Get stations with highest votes.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> GetByMostVotedAsync(uint limit = 0, QueryOptions? options = null);

        /// <summary>
        /// Get stations by recent clicks.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> GetByRecentClickAsync(uint limit = 0, QueryOptions? options = null);

        /// <summary>
        /// Get recently changed stations.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> GetByLastChangesAsync(uint limit = 0, QueryOptions? options = null);

        /// <summary>
        /// Get the stations that did not pass the connection test.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <returns>Array of stations.</returns>
        Task<StationInfo[]> GetBrokenAsync(uint offset = 0, uint limit = 1000);



        /// <summary>
        /// Get stations check results.
        /// </summary>
        /// <param name="stationuuid">If set, only list check result of the matching station.</param>
        /// <param name="lastcheckuuid">If set, only list checks after the check with the given check.</param>
        /// <param name="seconds">If > 0, it will only return history entries from the last 'seconds' seconds.</param>
        /// <param name="limit">Number of returned datarows (checks).</param>
        /// <returns>Array of station checks.</returns>
        Task<StationCheck[]> GetChecksAsync(Guid? stationuuid = null, Guid? lastcheckuuid = null, uint seconds = 0, uint limit = 999999);

        /// <summary>
        /// Get stations check steps.
        /// </summary>
        /// <param name="uuids">MANDATORY, comma-separated list of UUIDs of stations.</param>
        /// <returns>Array of station check steps.</returns>
        public Task<StationCheckStep[]> GetCheckStepsAsync(IEnumerable<Guid> uuids);
    }
}
