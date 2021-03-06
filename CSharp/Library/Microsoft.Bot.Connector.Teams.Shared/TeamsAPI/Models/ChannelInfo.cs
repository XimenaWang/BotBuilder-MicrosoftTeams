// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// A channel info object which decribes the channel.
    /// </summary>
    public partial class ChannelInfo
    {
        /// <summary>
        /// Initializes a new instance of the ChannelInfo class.
        /// </summary>
        public ChannelInfo() { }

        /// <summary>
        /// Initializes a new instance of the ChannelInfo class.
        /// </summary>
        /// <param name="id">Unique identifier representing a channel</param>
        /// <param name="name">Name of the channel</param>
        public ChannelInfo(string id = default(string), string name = default(string))
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Gets or sets unique identifier representing a channel
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets name of the channel
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
