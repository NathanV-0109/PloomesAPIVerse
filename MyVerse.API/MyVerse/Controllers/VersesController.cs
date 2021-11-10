using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyVerse.Context;
using MyVerse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVerse.Controllers
{
    /// <summary>
    /// Class of controls related to elements of type "Back" PUT, POST, GET, DELETE
    /// </summary>
    [Route("api/")]
    [ApiController]
    public class VersesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public VersesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// This method gets all data recorded within the server(Not Necessary Authentication)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[controller]/Get")]
        public async Task<IActionResult> GetVerses()
        {
            return Ok
            (
                new
                {

                    success = true,
                    data = await _appDbContext.Verses.ToListAsync()
                }
            );
        }

        /// <summary>
        /// This method adds new elements of type "Verse" to the server(Necessary Authentication)
        /// </summary>
        /// <param name="verse"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        [Route("[controller]/Post")]
        public async Task<IActionResult> CreateVerse(Verses verse)
        {
            
            _appDbContext.Verses.Add(verse);
            await _appDbContext.SaveChangesAsync();

            return Ok(
                new
                {
                    success = true,
                    data = verse
                });
        }

        /// <summary>
        /// This method edits an existing item, finding it by Id, after that the "Modified Verse" element is updated on the server(Necessary Authentication)
        /// </summary>
        /// <param name="verseModificed"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        [Route("[controller]/Put")]
        public async Task<IActionResult> ModificVerse(Verses verseModificed, int id)
        {
            var verse = await _appDbContext.FindAsync<Verses>(id);
            verse.Book = verseModificed.Book;
            verse.Chapter = verseModificed.Chapter;
            verse.Text = verseModificed.Text;
            verse.Verse = verseModificed.Verse;
            _appDbContext.Update(verse);
            await _appDbContext.SaveChangesAsync();
            return Ok(
                new
                {
                    success = true,
                    data = verse
                });
        }

        /// <summary>
        /// This method deletes the element through its Id(Necessary Authentication)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Authorize]
        [Route("[controller]/Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var verse = await _appDbContext.FindAsync<Verses>(id);
            if(verse != null)
            {
                _appDbContext.Remove(verse);
                await _appDbContext.SaveChangesAsync();
                return Ok(
                new
                {
                    success = true,
                    data = await _appDbContext.Verses.ToListAsync()
                });
            }
            return NotFound();
            
        }

    }
}
