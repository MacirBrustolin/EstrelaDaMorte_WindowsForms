using System.Collections.Generic;

namespace EstrelaDaMorte_WindowsForms.ViewModels {
    public class ResultadoApi<ViewModel> {
        public string Next { get; set; }
        public IReadOnlyList<ViewModel> Results { get; set; }
    }
}