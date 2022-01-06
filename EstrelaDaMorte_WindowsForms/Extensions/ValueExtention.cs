using System.Data.SqlClient;

namespace EstrelaDaMorte_WindowsForms.Extensions {
    public static class ValueExtension {

        public static T GetValueOrDefault<T>(this SqlDataReader reader, string campo) {
            try {
                return (T)reader[campo];
            } catch {
                return default(T);
            }
        }

    }
}