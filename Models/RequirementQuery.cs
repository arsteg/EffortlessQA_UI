﻿namespace EffortlessQA.UI.Models
{
    public class RequirementQuery
    {
        public string SearchTerm { get; set; } = string.Empty;
        public string SortBy { get; set; } = string.Empty;
        public string SortDirection { get; set; } = string.Empty;
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 10;
    }
}
