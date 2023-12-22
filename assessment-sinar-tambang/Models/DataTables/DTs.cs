using System.ComponentModel.DataAnnotations;

namespace assessment_sinar_tambang.Models.DataTables
{
    public class Matakuliah
    {
        [Key]
        public string Kode_MK { get; set; }
        public string Nama_MK { get; set; }
        public long SKS { get; set; }
    }

    public class Dosen
    {
        [Key]
        public string Nip { get; set; }
        public string Nama_Dosen { get; set; }
    }
}
