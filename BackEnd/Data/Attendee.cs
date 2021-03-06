﻿using System.Collections.Generic;
using ConferenceDTO;

namespace BackEnd.Data
{
    public class Attendee : ConferenceDTO.Attendee
    {
        public virtual ICollection<ConferenceAttendee> ConferenceAttendees { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
