using System;
using System.Threading.Tasks;

namespace RadioBrowserNet.Services
{
    public interface IModify
    {
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
