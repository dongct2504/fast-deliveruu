﻿using FastDeliveruu.Application.Dtos.GenreDtos;
using FastDeliveruu.Domain.Entities;

namespace FastDeliveruu.Application.Interfaces;

public interface IGenreServices
{
    Task<IEnumerable<Genre>> GetAllGenresAsync();
    Task<Genre?> GetGenreByIdAsync(int id);
    Task<Genre?> GetGenreWithMenuItemsByIdAsync(int id);
    Task<Genre?> GetGenreByNameAsync(string name);

    Task<int> CreateGenreAsync(Genre genre);
    Task UpdateGenreAsync(Genre genre);
    Task DeleteGenreAsync(Genre genre);
}
