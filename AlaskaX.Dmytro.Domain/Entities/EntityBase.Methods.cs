using Newtonsoft.Json;

using NUlid;

namespace AlaskaX.Dmytro.Domain.Entities
{
    public abstract partial class EntityBase
    {
        public EntityBase(bool aAutoIdentity = true)
        {
            if (!Guid.HasValue && aAutoIdentity)
                Guid = Ulid.NewUlid().ToGuid();
        }

        /// <summary>
        /// Enable entity base.
        /// Sets IsEnabled field as true
        /// Virtual method.
        /// </summary>
        public virtual EntityBase Enable()
        {
            IsEnabled = true;

            return this;
        }

        /// <summary>
        /// Disable entity base.
        /// Sets IsEnabled field as false
        /// Virtual method.
        /// </summary>
        public virtual EntityBase Disable()
        {
            IsEnabled = false;

            return this;
        }

        /// <summary>
        /// Guid to be used and validated inside .net
        /// Should not be recorded in database
        /// </summary>
        [JsonIgnore]
        public virtual Guid? Guid
        {
            get => string.IsNullOrEmpty(Id.Trim()) ? Ulid.NewUlid().ToGuid() : new(Id);
            set
            {
                Id = value != null ? value.Value.ToString() : string.Empty;
            }
        }
    }
}
