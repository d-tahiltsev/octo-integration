using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AlaskaX.Dmytro.Application.Services.DTOs.Authentication
{
    [Serializable]
    [DataContract]
    public partial class DTOAuthenticationResponse(string aJwt)
    {
        [DataMember]
        public string Jwt { get; private set; } = aJwt;

        [DataMember]
        [DataType(DataType.DateTime)]
        public DateTime When { get; private set; } = DateTime.UtcNow;
    }
}
