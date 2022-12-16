# Web-App-501

**WebApp501** - defense project for [**ASP.NET Advanced**](https://softuni.bg/trainings/3854/asp-net-advanced-october-2022) course at [SoftUni](https://softuni.bg/ "SoftUni") (October 2022).

# Project Introduction

**WebApp501**  is a website for creating cocktais.

# Project Description of functionalities

Users can  **view / create / edit / delete**  "Cocktails".

-   All users can browse the site;
-   All authorized users can become bartenders and add their own cocktails;
-   Created cocktails are saved for all  bartenders;
-   Cocktails may be edited or deleted only by their creator or by the administrator;
-   Cocktails can have names, recipes, preparation, who are they created from and more;
-   Administrators have full access to the site. Editing, deleting cocktails or users.

## User Types

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

# Used technologies

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

# Test Coverage
![enter image description here](https://lh3.googleusercontent.com/caNw1iBAEn1TK12fZHvWDBQjWGx63wCuKhkIivgHyXl026-_2B0keMB-o7j-6vtHNaYQ0h4TE1aCPtZpkSRITz4XXtOZqyddNe6_j8AMCGlt4Vnl3ZYT0WnY7hMP1NN-T7zJfXqumEtkBRFx9wucNNJAICi9-FTqPF1D91rXtV-RYCePqLJjOk0udDcWZgBV7i7HfVsuvSynkcK1a6J_OfUeptmgD6J5KPQpDoC_kmz-uM2-RI1DF9fmKWiWiZ5tPN6CHJc-SlPRBO5qDP5kHnqL3Yiw4xejHmHCSdBWbzAvDCE5qXs4-DIhrpwI1h-vuUjHMZeH73Fd3VL84OCmhPQbisaDDmB-eSZ1WPBZqfHIT3HKEYiFIGjVVvzwUC4-a_IagrK5FIF8kN8IAxKGSQRWOujFf3pSjzuZjSRzUAOSbRwmZZYtvRsHjqVeGxuTAWK4Ab9fCixvvqaZ8sg7jzJK-qHgs2cyqFAuvBiZ2mmNj1OKT5_NrxyqzcBCebZsV6FWHdJB-kfoKyyqw8uqJknZ0OfDrqH5Y5aMT3JTl0AhSsWAkKrDcMIFHTlSj7i-DEMfC9INzaAceTJ7yhzTxiQEFGtTNIsuR_MZGbuvyPRXZwUX5CIrwpxiw_JWXFtYrTh8iJoBsRA7woTALXBBjt1u0ZxejaAajgdzEAQ3LH3u3dxuR9sw2NVP80KQyYXloJZ6k5tGPP_xIlqJ_tzMObJjV9qJI_ASCcY3VW0MitODpRRc97ynK0mRcUNhqsM4ygH74C0hsrX2LN9_9xu8-64BVNQqPVwYQjUFbh47vW8hsVqC39cGUVPu60TjJUJaLmD45S9kWUv-6rnmCKcD9iMEkl8eEYdeUN-7Uf9p1J9uHhxCcCXWxsIJHNwkOm-CjiHbBFNBS05ckjjNhE8632Vc31CN1rWSrDbErK_Tan4=w621-h384-no?authuser=0)

# DB Diagram
![enter image description here](https://lh3.googleusercontent.com/2Pj2iAB02_5DJL8JtU3VmilZfuftXfkqaab6qJ4q4AemvsbJ1ANQvVWK_yaBv8XwK3fTTIuT9wCTAYWGEsS-fwXtendpxBm7Au3pDY7jr2X_6s7UvsUDtspM-cdbKJOB7V2bnQE670HIcR2U8Ff4tys2V7Ubo9qdkPChek5zQCCboHCSP99vXzRWXiG-3_1Dig8KJ1pESxNQMJFE7M7aJk9R93o87wItBk1Ov6eKr48pIYz6vlCWcXZjsLl5XhmQyyCF9uWghPVXsWKFPb8g6SbT5QYkS5imZsvzxc7Sa50GgKmp8-1s_-pSiqEu1z7FhbqLOM88dyjpKTlT2Yv-qtQcq1pNlae03U0ksGHt4PtAcpnp_gv-I8bAnAPOSbSEeb0J1cYsWPNSHhvblnkKGS7dQ9iZn5uZgwSgQkPgIBse28xwbAGIC0zkcGPRIz4VLiZI_mo_6yF8DhBqHDahfiGCjUdENMWhDnsY6a6i1BcoVWj519_RS9z3r6pPOtxUs53V7Dk8QEk1dBMwFPwZ1d_xIuL2FglWF4-nThvc-BbTK0G7Cpn8MAAugM9ae49-L5-5z6mqFdsLnU7C9EfTEvRxk00RoJG4GIKLdVkax_0m-kMIz-1RRbHgio2XNUASb2StJpsTCGHACHQHiT6t1Nxm0910N4-Lto0SxOhUqgYsdR7aK8VVe--LYiLKQ6h9GQmiYbrTbXh6k4T8abyYkALa-ixeGlHlk4j2qBobkmzj8yfC23lwH6mWKGleSV8sexFIQpgFymJ9gdjyPTle4jNkblnQnY7j_SkQ2M_1J5PeeT4B5_WkAk6-yFGbqj4_hVyHivm7awgWZrNDpvMbXyrA2FjrU3diiPHvXoneVilQatyyhnsjsI7PQpHaUhsoGakWx4gNYgTiRu2jtvNezF00J0uo5-y-dEvjkDCjoLQ=w1026-h841-no?authuser=0)

## Author Name

Dimitar Byalkov
