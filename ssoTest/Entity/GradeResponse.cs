using System.Runtime.Serialization;

namespace ssoTest.Entity
{
    [DataContract]
    public class GradeResponse
    {
        [DataMember]
        public string AdminUserId { get; set; }

        [DataMember]
        public string Result { get; set; }

        [IgnoreDataMember]
        public string StatusCode { get; set; }
    }
}