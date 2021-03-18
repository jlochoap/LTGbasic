# LTGbasic

Basic image pages downloader for Libros de Texto Gratuitos (Mexico's free basic education school books)

## 2021 Important Notice ##

As expected from the Mexico government, the interests of the money-grubbing book editorials is more important than the education of our children, so the directories structure has been changed, a warning notice added to the site mentioning that the download is illegal and many middle education books reading has been redirected to the books' editorials' own reader apps. Hence, this app is now obsolete. Thank our government!

## Wiki

### What are Libros de Texto Gratuitos?

These books are made (and/or distributed) by the [Comisión Nacional de Libros de Texto Gratuitos](https://www.conaliteg.sep.gob.mx/) (a public descentralized organ of Mexico Government's Public Education Ministry SEP), and are freely provided to all basic education students in the national eduaction system.

### What is LTGbasic

Simply, it is a serial image downloader. Once you determine which school year, and which code of book you require, LTGbasic downloads the image files for the complete book (or some pages, as required). You can visualize the pages in an image viewer, or assemble a PDF file if you have Acrobat or other PDF binder.

### Why LTGbasic
Currently, the site for the free books only allows the online viewing of the books. A site for certain downloads was available, but is currently offline. Many students don't have the chance of accessing these books due to a lack of functioning internet connection, so a local copy of the book is necessary.

### Features
- Autofill for current and historical servers.
- Automatic retrieve of book's total page number.
- Image download retry on error.

### How the servers are organized
One server offers downloads of the books in PDF format, but only for current school year, and not all grades. The CONALITEG site allows visualization of all the books on a tailored image visualization web app. If you require to download the books, you can get the image files from the server.

The files are organized in directories by book's code. Each image is an JPG file and is named by page number, with zero filling to three digits, e.g., "012.jpg". The visualizer's htm (named by book's code) page also includes a variable that allows a javascript to know the total page number.

Current school year's books server, directory, htm file and jpg files examples:
```
https://libros.conaliteg.gob.mx/P1LEA.htm
https://libros.conaliteg.gob.mx/c/P1LEA/024.jpg
```

For historical records:
```
https://historico.conaliteg.gob.mx/H1960P1ES002.htm
https://historico.conaliteg.gob.mx/c/H1960P1ES002/034.jpg

```
### How it works

Once the server and book code are known, LTGbasic uses a WebClient to download the image files, retrying the download in case of failure up to a number of retries. LTGbasic can also try to retrieve the total number of pages for a book.

## Links

### Official

[https://www.conaliteg.sep.gob.mx/](https://www.conaliteg.sep.gob.mx/)
Government site for the committee that produces the Libros de Texto Gratuito.

[https://libros.conaliteg.gob.mx/catalogo.htm](https://libros.conaliteg.gob.mx/catalogo.htm)
Free books catalog for the current school year.

[https://librosdetexto.sep.gob.mx/](https://librosdetexto.sep.gob.mx/)
PDF books for the current school year, for pre-escolar, primaria and telesecundaria only.

[https://historico.conaliteg.gob.mx/](https://historico.conaliteg.gob.mx/)
Historical record of free text books in past school years.
