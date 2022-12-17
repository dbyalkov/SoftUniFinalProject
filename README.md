## Web-App-501

**WebApp501** - defense project for [**ASP.NET Advanced**](https://softuni.bg/trainings/3854/asp-net-advanced-october-2022) course at [SoftUni](https://softuni.bg/ "SoftUni") (October 2022).

## Project Introduction

**WebApp501**  is a website for creating cocktais.

## Project Description of functionalities

Users can  **view / create / edit / delete**  "Cocktails".

-   All users can browse the site;
-   All authorized users can become bartenders and add their own cocktails;
-   Created cocktails are saved for all  bartenders;
-   Cocktails may be edited or deleted only by their creator or by the administrator;
-   Cocktails can have names, recipes, preparation, who are they created by and more;
-   Administrators have full access to the site. Editing, deleting cocktails or users.

### User Types

**Administrator**  - user with privileges

-   Create, read, edit, delete all cocktails or users on the site;
-   See all cocktails;
-   See all users.

**User**  - logged-in user

-   Can become a bartender;
-   Can view all cocktails.

**Bartender**  - user who become a bartender

-   Create cocktails and edit or delete them;
-   Users can manage only cocktails they created;
-   Can view all cocktails.

**Anonymous**  - users without an account

-   Can view all cocktails.

## Used technologies

-   ASP.NET Core 6:
    -   Database layer wtih 5 entity models;
    -   UI layer with 3 controllers + 4 more in the “Admin” area;
    -   Service layer with 4 services;
    -   Test layer for services with 25 tests;
    -   19 views + 3 partial views.
-   Entity Framework Core;
-   Microsoft SQL Server;
-   AutoMapper;
-   TempData messages;
-   NUnit.

## Test Coverage
![](https://lh3.googleusercontent.com/U4kmrZQXdd_WPTlUjmcitPlsK8_urJy6uG4gjAi_s9SPz868HAO0Vz5xpqZAbHs5oz-dUqg1nP2fHtX1z8tY13pIzhp6-jeq8VnLbz1Inx1JXfm_Mj7nJBdH2GFRGjR54EqeVLBj39_-5RlMcqLEhfbPrtMMeTZ1ASB1xAdAgQMiJU9aW8Gkfr4If1wZgu4_GBdHuvkj91JgrWOU-uwl1PdsiF62oPBkKTCyLslsTQGEDoIP-k-BexpCp8kLN5Y4GWtQqvkay4Rggrftd9PQz44zMZyNRdRZQtbDvmFJIVTPH8Q5hvBL3RsmYnRGauxFEnoyOWgDSxLWlD5rP-nBrmuxxO0h8eGkNVbA3667-didrt5zKSK1inZIspII-ERLE6_C-FNzuPK4nFCxFYaC8AJ7XXhtEHqu0uITqCyPQlXqB2PzbN2745nm3koXml-Mpv4OdClu5h3WNiFtTcCL94CTvo6ibsa3t3X-rFLT4kSvnACR1rBf0cNONUVJoGGwTfEBZGvTOy6A3t_LVwiIri8fhD1E8aa7uI61MyjBNbVIUrMe-RgZ_l2XFb0y_dcAzG8lcqSFFmB9jzGWBt5FyQlJOku2w5kZGfHJ23nhaAkCRwqINtLtWOP17u8ALfFPIvO_FnucYN5YvkNx0I5YXbnSuX9ygOFa8w-Vw1cD1bRyQJXmImEr9Q6el6OZfXXXkc6XJkNgyER6E6pbeNm0sdck-WRZarCBziEi5DbHCKryiZl3bXLfUqvrb_LXyRfvAufXFRneYIF3a12ySkmZ-KLpNdnD6jBH5prK28YSPkXdyZL_gpDhn8q0mWNd0-YqKpnBTr48vusJ6aXIzmrpHZ235Zq9K2CuBo-ZKISZKi8-YgIRlwvyw5EPX1VOfQkBlg952WvFyX8tSPK0Rq9hIofagiCb5N6NZoS1Av8N390=w621-h384-no?authuser=0)

## DB Diagram
![](https://lh3.googleusercontent.com/59W9d4-gLlVKsH7-1DGTNsCmN8CyCA1bqZfHmgoGvEWBLm1SuiatbeIALQv-lww9HYJgBZ4UzdcqrBATvPdQFllD2pLYsdHDhMV3PzZxKV3G79SK_iAmi1vv9yLyOqHS6Oy2Q5Ab2LH2RBQrbwk6AUCgvpSXD8wToHGBB0XjMwxFFo1k__lIuvbLzBRBR3X_Vkq0xAtbPi8P81H3uKc-a3ivm3Bq6t8cMKdunrihiH3O7rdBPQ428-bNVqdC8tXKBpkL-hzeJslNWFivqwYIPesQIbv7CHti1OO-UqIrWB6RSwu93XBpOS5rfhVJL-VDAN9ULErl3FL-lcxAyS8giq6xDa3u8viQAgAGvTVtu_Kes5xUTUQw08hAa8GST-PmZoiUu9B6rxVsA3xS1PP54Xz65BSbjFcl-lV3NkG_-d9OuQ0Il6bpeuoTCYhK14p02R384-qxD7XgYDQxnvXQJugmO9JhjiHTL-s9LT39sNmIEt14wjkoYinWdjTfIM14qk9n7CDxrmdQQBbHV5dI9s5jDcUV2gSbiY4VJIiGT6bP88VV6jdB8NL8Wo9iODGcdwkTa1Qh3wVb4fUimlgJmDqoc4cOom6KuzgFd9cbrq8_blTypv1BYatjax1Lh2C7PeG0Nj6LAr11xtxGk9JuSTx0E2V_GzfTtOf76UEhGnSo84wGETWEJ0jOeTpgq8ucEJDntDQ-VgXI39Uwi_15BJ5gImuRyqtPhSBWGCY_h2NFO86UCZfI5Pq8r6w8FB20i-vxfV5Nl8iyvhOoDZ_M_xgbz-3aPY0ofa-83pC1vNhqFSB47IqZI2OPCdY-zXYY0OFXyBJGi5KFQkOwM0xVEHIfqOPbiWa4kx0Cu_yPRmDH_S4Y97XZX66-flhL6gnlS3ZzbG92hUKnwnPAgY1OG8YKV-uEPMHDLlgvcEiLTY0=w1026-h841-no?authuser=0)

## Author Name

Dimitar Byalkov
