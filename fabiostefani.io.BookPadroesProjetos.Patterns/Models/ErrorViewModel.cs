using System;

namespace fabiostefani.io.BookPadroesProjetos.Patterns.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
