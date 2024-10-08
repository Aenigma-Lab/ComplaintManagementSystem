using System;
using System.ComponentModel.DataAnnotations;

namespace ComplaintMngSys.Models.ComplaintViewModel
{
    public class StatusUpdateViewModel
    {
        public Int64 Id { get; set; }
        public Int64 ComplaintId { get; set; }
        public int Status { get; set; }
        //[Required]
        [Display(Name = "New Comment")]
        public string NewComment { get; set; }

        public static implicit operator StatusUpdateViewModel(Complaint _Complaint)
        {
            return new StatusUpdateViewModel
            {
                Id = _Complaint.Id,
                Status = _Complaint.Status,
            };
        }

        public static implicit operator Complaint(StatusUpdateViewModel vm)
        {
            return new Complaint
            {
                Id = vm.Id,
                Status = vm.Status,
            };
        }
    }
}
