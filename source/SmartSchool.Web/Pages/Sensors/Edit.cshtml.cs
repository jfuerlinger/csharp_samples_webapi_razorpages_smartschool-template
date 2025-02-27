﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartSchool.Core.Contracts;
using SmartSchool.Core.Entities;

namespace SmartSchool.Web.Pages.Sensors
{
  public class EditModel : PageModel
  {
    private readonly IUnitOfWork _unitOfWork;

    public EditModel(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> OnGet(int? id)
    {
      throw new NotImplementedException();
    }

    public async Task<IActionResult> OnPost()
    {
      throw new NotImplementedException();
    }
  }
}