using System.Runtime.Serialization;

namespace SharpCaster.Models.ChromecastRequests
{
    [DataContract]

    public class VolumeDataObject
    {
        [DataMember(Name = "level")]
        public float Level { get; set; }
    }
}