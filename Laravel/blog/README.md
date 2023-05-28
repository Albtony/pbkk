Nama: Blog </br>
Deskripsi: </br>
Merupakan web yang dibangun sesuai tutorial https://www.itsolutionstuff.com/post/laravel-8-user-roles-and-permissions-tutorialexample.html. Pada web ini kita dapat login dengan email dan password. Website ini juga dapat menampilkan produk yang telah didaftarkan. Selain itu, pada web ini terdapat berbagai role yang mengatur permission seorang user, permission ini meliputi operasi CRUD untuk role dan produk. </br>

Pertanyaan: </br>
1. Entitas/model apa saja yang terlibat di dalam aplikasi tersebut?</br>
    - User: merepresentasikan user aplikasi </br>
    - Product: merepresentasikan produk aplikasi </br>
    - Role: merepresentasikan role/peran aplikasi </br>
    - Permission: merepresentasikan permission dalam aplikasi </br>
2. Use case aplikasi. Format: <Jenis role> dapat melakukan <suatu fitur> </br>
    - User dapat melakukan operasi CRUD terhadap produk aplikasi </br>
    - User dapat melakukan operasi CRUD terhadap role user aplikasi </br>
    - User dapat melakukan operasi CRUD terhadap user-user lainnya </br>
3. Controllers, Middleware, dan library tambahan yang digunakan beserta fungsinya masing-masing</br>
    - Library yang digunakan adalah </br>
        - spatie/laravel-permission: memberikan fungsionalitas role dan permission untuk aplikasi</br>
        - laravel/ui: mengenerate UI, layout dan memberikan fungsionalitas autentikasi aplikasi</br>
        - laravelcollective/html: memberikan fungsionalistas html form builder </br>
    - Middleware yang digunakan adalah </br>
        - role: middleware asal laravel-permission, digunakan untuk membatasi akses ke route/controller tertentu berdasarkan role (ngecek role) </br>
        - permission: middleware asal laravel-permission, digunakan untuk membatasi akses ke route/controller tertentu berdasarkan permission (ngecek permission)</br>
        - role_or_permission: middleware asal laravel-permission, digunakan untuk membatasi akses ke route/controller tertentu berdasarkan role atau permission (ngecek ada permission/role)</br>
    - Controller yang digunakan adalah </br>
        - userController: memediasi interaksi CRUD view kepada User (index, create, store, show, edit, update, destroy)</br>
        - roleController: memediasi interaksi CRUD view kepada Role (index, create, store, show, edit, update, destroy)</br>
        - productController: memediasi interaksi CRUD view kepada Product (index, create, store, show, edit, update, destroy)</br>
4. DB, external interfaces: struktur tabel database yang digunakan. </br>
    - Tabel yang digunakan pada database adalah</br>
        - users (id, name, email, password)</br>
        - roles (id, name)</br>
        - permissions (id, name)</br>
        - role_has_permissions (permission_id, role_id)</br>
        - products (id, name, detail)</br>
    - External interfaces yang digunakan adalah </br>
        - library laravel/ui: mengenerate UI, layout dan memberikan fungsionalitas autentikasi aplikasi</br>
        - library laravelcollective/html: memberikan fungsionalistas html form builder </br>

Video Dokumentasi: https://youtu.be/DoCXlD1gowY </br>
