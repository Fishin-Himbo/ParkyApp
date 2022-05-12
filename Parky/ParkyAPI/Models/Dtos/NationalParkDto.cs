using System;
using System.ComponentModel.DataAnnotations;

namespace ParkyAPI.Models.Dtos
{
    public class NationalParkDto
    {
        public NationalParkDto()
        {
        }

        public NationalParkDto(NationalPark np)
            : this(
                  np.NationalParkId,
                  np.NationalParkName,
                  np.StateId,
                  np.CreatedDtim,
                  np.CreatedUser,
                  np.ModifiedDtim,
                  np.ModifiedUser)
        {
        }

        public NationalParkDto(
            int nationalParkId,
            string nationalParkName,
            int stateId,
            DateTime createdDtim,
            string createdUser,
            DateTime modifiedDtim,
            string modifiedUser)
        {
            this.NationalParkId = nationalParkId;
            this.NationalParkName = nationalParkName;
            this.StateId = stateId;
            this.CreatedDtim = createdDtim;
            this.CreatedUser = createdUser;
            this.ModifiedDtim = modifiedDtim;
            this.ModifiedUser = modifiedUser;

        }

        public int NationalParkId { get; set; }

        public string NationalParkName { get; set; }

        public int StateId { get; set; }

        public DateTime CreatedDtim { get; set; }

        public string CreatedUser { get; set; }

        public DateTime ModifiedDtim { get; set; }

        public string ModifiedUser { get; set; }

        public NationalPark ToNationalPark()
        {
            return new NationalPark
            {
                NationalParkId = this.NationalParkId,
                NationalParkName = this.NationalParkName,
                StateId = this.StateId,
                CreatedDtim = this.CreatedDtim,
                CreatedUser = this.CreatedUser,
                ModifiedDtim = this.ModifiedDtim,
                ModifiedUser = this.ModifiedUser
            };
        }
    }
}
