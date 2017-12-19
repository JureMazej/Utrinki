namespace WinFormsUPORABNIKI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UPORABNIKI")]
    public partial class UPORABNIKI
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string IME { get; set; }

        [Required]
        [StringLength(30)]
        public string PRIIMEK { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATUM_ROJSTVA { get; set; }

        [Column(TypeName = "text")]
        public string KOMENTAR { get; set; }
    }
}
