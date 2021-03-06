﻿using Nelibur.ObjectMapper;
using PagedList;
using ResourceBlender.Common.Exceptions;
using ResourceBlender.Common.ViewModels;
using ResourceBlender.Domain;
using ResourceBlender.Repository.Contracts;
using ResourceBlender.Services.Contracts;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace ResourceBlender.Presentation.Controllers
{
  public class ResourcesController : Controller
  {
    private readonly IResourcesService _resourcesService;
    private readonly IResourceRepository _resourceRepository;
    private readonly IFileService _fileService;
    
    public ResourcesController(IResourcesService resourcesService, IResourceRepository resourceRepository, IFileService fileService)
    {
      _resourcesService = resourcesService;
      resourcesService.BaseUri = GetUrl();
      _resourceRepository = resourceRepository;
      _fileService = fileService;
    }

    string GetUrl()
    {
      var request =System.Web.HttpContext.Current.Request;
      var appUrl = HttpRuntime.AppDomainAppVirtualPath;

      if (appUrl != "/")
        appUrl = "/" + appUrl;

      var baseUrl = string.Format("{0}://{1}{2}", request.Url.Scheme, request.Url.Authority, appUrl);

      return baseUrl;
    }

    public async Task<ActionResult> Index(int? page, string searchTerm = "")
    {
      var viewModel = await _resourcesService.GetResources();

      if (viewModel == null)
      {
        return View(viewModel);
      }
      else
      {
        if (!string.IsNullOrEmpty(searchTerm))
        {
          searchTerm = searchTerm.ToLower();
          viewModel = viewModel.Where(x => x.ResourceString.ToLower().Contains(searchTerm) ||
                                                                              x.EnglishTranslation.ToLower().Contains(searchTerm) ||
                                                                              x.RomanianTranslation.ToLower().Contains(searchTerm))
                                                                              .ToList();
        }

        int pageSize = 10;
        int pageNumber = (page ?? 1);
        return View(viewModel.ToPagedList(pageNumber, pageSize));
      }
    }

    [HttpGet]
    public ActionResult ImportResources() => View();


    [HttpPost]
    public ActionResult ImportResources(ImportFileViewModel model)
    {
      if (model.files.Any(x => x == null))
      {
        ModelState.AddModelError("RequiredFile", "Both files are required.");
      }
      if (ModelState.IsValid)
      {

        _resourcesService.AddOrUpdateRomanianResourcesOnImport(model.files.ElementAt(0));
        _resourcesService.AddOrUpdateEnglishResourcesOnImport(model.files.ElementAt(1));

        return RedirectToAction("Index");
      }
      else
      {

        return View(model);
      }
    }

    public PartialViewResult ShowErrorMessage(string message)
    {
      return PartialView("_Error");
    }

    public ActionResult ExportResources()
    {
      var archive = _fileService.GetArchive();
      return File(archive.ToArray(), "application/zip", "res.zip");
    }

    //public ActionResult ExportEnglishResources()
    //{
    //  return new FileGeneratingResult("Resources.resx", "application/xml", stream => _fileService.GenerateExportFile(stream, LanguageEnumeration.English));
    //}

    public ActionResult AddResource() => View();

    [HttpPost]
    public async Task<ActionResult> AddResource(ResourceViewModel model)
    {
      if (ModelState.IsValid)
      {
        try
        {
          await _resourcesService.AddResource(model);
          return RedirectToAction("Index");
        }
        catch(ResourceAlreadyExistsException ex)
        {
          TempData["ErrorMessage"] = ex.Message;
          return View(model);
        }
      }
      else
      {
        return View(model);
      }
    }

    public ActionResult Update(int resourceId)
    {
      ResourceViewModel resource = _resourcesService.GetResourceById(resourceId);

      if (resource != null)
      {
        return View(resource);
      }

      return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<ActionResult> Update(ResourceViewModel model)
    {
      if (ModelState.IsValid)
      {
        await _resourcesService.UpdateResource(model);
        return RedirectToAction("Index");
      }
      else
      {
        return View(model);
      }
    }

    public async Task<ActionResult> Delete(int resourceId)
    {
      ResourceViewModel resource = _resourcesService.GetResourceById(resourceId);

      if(resource != null)
      {
        return View(resource);
      }
      else
      {
        return RedirectToAction("Index");
      }
    }

    [HttpPost]
    public async Task<ActionResult> Delete(ResourceViewModel viewModel)
    {
      try
      {
        await _resourcesService.DeleteResource(viewModel);
        return RedirectToAction("Index");
      }
      catch(ResourceDoesNotExistException ex)
      {
        TempData["ErrorMessage"] = ex.Message;
        return View();
      }
    }

    public ActionResult GenerateResources() => View();
  }
}