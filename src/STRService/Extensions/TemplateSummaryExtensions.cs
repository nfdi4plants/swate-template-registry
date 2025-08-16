using STRService.Components.Models;

namespace STRService.Extensions
{
    public static class TemplateSummaryExtensions
    {
        public static TemplateSummary[] SortTemplatesBy(this TemplateSummary[] templates, string sortColumn, bool ascending)
        {
            return (sortColumn, ascending) switch
            {
                ("Name", true) => templates.OrderBy(t => t.Name).ToArray(),
                ("Name", false) => templates.OrderByDescending(t => t.Name).ToArray(),
                ("ReleaseDate", true) => templates.OrderBy(t => t.ReleaseDate).ToArray(),
                ("ReleaseDate", false) => templates.OrderByDescending(t => t.ReleaseDate).ToArray(),
                _ => templates
            };
        }
    }
}
