using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO_Praktikum.Database;
using UTS_PBO_Praktikum.StrukturData;

namespace UTS_PBO_Praktikum.CRUD
{
    internal class CRUD_Kontak : Database_Kontak
    {
        private static string table = "daftar_kontak";

        public static DataTable All()
        {
            string query = @"
        SELECT 
            id_fasilitas_gym,
            nama_orang,
            email_orang,
            no_tlp,
        FROM 
            daftar_kontak";

            DataTable datakontak = queryExecutor(query);
            return datakontak;
        }

        public static DataTable getFasilitasGymById(int id)
        {
            string query = @"
                SELECT 
                    id_fasilitas_gym,
                    nama_orang,
                    email_orang,
                    no_tlp
                FROM 
                    daftar_kontak
                WHERE 
                    id_fasilitas_gym = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id }
            };

            DataTable datakontak = queryExecutor(query, parameters);
            return datakontak;
        }


        public static void Addkontak(Stukturkontak kontakbaru)
        {
            string query = $"INSERT INTO {table} (nama_orang, email_orang, no_tlp) VALUES(@nama_orang, @email_orang, @no_tlp";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_orang", kontakbaru.nama_orang),
                new NpgsqlParameter("@email_orang", kontakbaru.email_orang),
                new NpgsqlParameter("@no_tlp", kontakbaru.no_tlp),
            };

            commandExecutor(query, parameters);
        }

        public static void Updatekontak(Stukturkontak kontak)
        {
            string query = $"UPDATE {table} SET nama_orang = @nama_orang, email_orang = @email_orang, no_tlp = @no_tlp WHERE id_fasilitas_gym = @id_fasilitas_gym";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_orang", kontak.nama_orang),
                new NpgsqlParameter("@email_orang", kontak.email_orang),
                new NpgsqlParameter("@no_tlp", kontak.no_tlp),
                new NpgsqlParameter("@id_fasilitas_gym", kontak.id_fasilitas_gym)
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteMahasiswa(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_fasilitas_gym = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };

            commandExecutor(query, parameters);
        }
    }
}
