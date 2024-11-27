using DigitalBazaarWeb.Data;
using DigitalBazaarWeb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DigitalBazaarWeb.Controllers;

public class CategoryController(AppDbContext context) : Controller
{
    
    #region Creating New Category

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category? category)
    {
        if (!ModelState.IsValid) return View();
        
        
        context.Categories.Add(category);
        context.SaveChanges();
        TempData["success"] = "Category Created Successfully";
        // TempData["error"] = "Failed To Create Category";
        return RedirectToAction("Index");

    }

    #endregion

    #region Display Category

    public IActionResult Index()
    {
        IEnumerable<Category?> categories = context.Categories;
        return View(categories);
    }

    #endregion

    #region Edit Category

    public IActionResult Edit(int? id)
    {
        if (id is null or 0)
        {
            return NotFound();
        }
        
        Category? category = context.Categories.FirstOrDefault(x => x != null && x.Id == id);
        
        if (category == null)
        {
            return NotFound();
        }
        
        return View(category);
    }

    [HttpPost]
    public IActionResult Edit(Category category)
    {
        if (!ModelState.IsValid) return View(category);
        
        var dbCategory = context.Categories.FirstOrDefault(c => c != null && c.Id == category.Id);
        if (dbCategory == null)
        {
            return NotFound();
        }
        
        if (dbCategory.Priority != category.Priority)
        {
            var isPriorityUsed = context.Categories.Any(c => c != null && c.Priority == category.Priority);
            if (isPriorityUsed)
            {
                ModelState.AddModelError("Priority", "This priority value is already in use.");
                return View(category);
            }
        }
        
        dbCategory.Title = category.Title;
        dbCategory.IsActive = category.IsActive;
        dbCategory.Priority = category.Priority;
        dbCategory.UpdatedDate = DateTime.Now;

        context.SaveChanges();
        TempData["success"] = "Category Updated Successfully";
        // TempData["error"] = "Failed To Update Category";
        return RedirectToAction("Index", "Category");

    }

    #endregion

    #region Delete Category

    public IActionResult Delete(int? id)
    {
        if (id is null or 0)
        {
            return NotFound();
        }
        
        Category? category = context.Categories.FirstOrDefault(x => x != null && x.Id == id);
        
        if (category == null)
        {
            return NotFound();
        }
        
        return View(category);
    }

    [HttpPost]
    public IActionResult Delete(Category? category)
    {
        if (category == null)
        {
            return NotFound();
        }
        context.Remove(category);
        context.SaveChanges();
        TempData["success"] = "Category Deleted";
        // TempData["error"] = "Failed To Delete Category";
        
        
        return RedirectToAction("Index", "Category");
    }

    #endregion
}