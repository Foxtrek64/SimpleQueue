//
//  Privacy.cshtml.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleQueue.Web.Pages
{
    /// <summary>
    /// Code behind for the privacy page.
    /// </summary>
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyModel"/> class.
        /// </summary>
        /// <param name="logger">A logger for this instance.</param>
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Builds a view which is returned on get.
        /// </summary>
        public void OnGet()
        {
        }
    }
}
