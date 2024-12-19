using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;

namespace AlaskaX.Dmytro.Domain.Entities
{
    public abstract partial class EntityBase
    {
        /// <summary>
        /// Product Id
        /// </summary>
        /// <remarks>
        /// I use Ulid here because this is full compatible with Guid, but orderable because it uses time stamp.
        /// So it is good for indexes optimizations by default. And works in any modern database.
        /// </remarks>
        [Key]
        [JsonProperty]
        public virtual string Id { get; protected set; } = string.Empty;


        /// <summary>
        /// Defines if product is enabled
        /// </summary>
        public bool IsEnabled { get; private set; } = false;


        /// <summary>
        /// Date when the object was created.
        /// </summary>
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    }
}
