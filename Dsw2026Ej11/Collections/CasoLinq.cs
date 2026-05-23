namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using System.Collections.Generic;
using System.Linq;

public class CasoLinq
{
    private List<Libro> libros = Libro.CrearLista();

    // 1. Obtener el primer libro
    public Libro GetPrimero() => libros.FirstOrDefault();

    // 2. Obtener el último libro
    public Libro GetUltimo() => libros.LastOrDefault();

    // 3. Obtener la suma de precios
    public decimal GetTotalPrecios() => libros.Sum(l => l.Precio);

    // 4. Obtener el promedio de precios
    public decimal GetPromedioPrecios() => libros.Average(l => l.Precio);

    // 5. Obtener la colección de libros con Id mayor a 15 
    public IEnumerable<Libro> GetListById() => libros.Where(l => l.Id > 15);

    // 6. Obtener una colección de cada libro con su título y precio en formato moneda
    public IEnumerable<string> GetLibros() => libros.Select(l => $"{l.Titulo} - {l.Precio:C}");

    // 7. Obtener el libro con el precio más alto
    public Libro GetMayorPrecio() => libros.OrderByDescending(l => l.Precio).FirstOrDefault();

    // 8. Obtener el libro con el precio más bajo
    public Libro GetMenorPrecio() => libros.OrderBy(l => l.Precio).FirstOrDefault();

    // 9. Obtener los libros cuyo precio sea mayor al promedio
    public IEnumerable<Libro> GetMayorPromedio()
    {
        decimal promedio = GetPromedioPrecios();
        return libros.Where(l => l.Precio > promedio);
    }

    // 10. Obtener los libros ordenados por título de forma descendente
    public IEnumerable<Libro> GetLibrosOrdenados() => libros.OrderByDescending(l => l.Titulo);
}
