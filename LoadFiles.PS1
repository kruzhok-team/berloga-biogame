# Введите путь к папке с файлами и подпапками
$source_folder = ".\assets"

# Пройдитесь по всем файлам в папке
Get-ChildItem -Path $source_folder -Recurse | ForEach-Object {
    # Получите полный путь к файлу
    $full_path = $_.FullName
    # Разделите путь на директорию и имя файла
    $local_path = $full_path.Replace("\", "/").Replace("assets", "|assets").Split("|")[1]
    Write-Host $local_path

    $file = Get-Item "$full_path"
    if ($file.PSIsContainer -eq $false) {

        Write-Host "https://storage.yandexcloud.net/public-media/$local_path"
        # Загрузите файл с сервера, перезаписав заглушку
        Invoke-WebRequest -Uri "https://storage.yandexcloud.net/public-media/berloga-biogame/$local_path" -OutFile $full_path
    }
}

# Введите путь к папке с файлами и подпапками
$source_folder = ".\addons"

# Пройдитесь по всем файлам в папке
Get-ChildItem -Path $source_folder -Recurse | ForEach-Object {
    # Получите полный путь к файлу
    $full_path = $_.FullName
    # Разделите путь на директорию и имя файла
    $local_path = $full_path.Replace("\", "/").Replace("addons", "|addons").Split("|")[1]
    Write-Host $local_path

    $file = Get-Item "$full_path"
    if ($file.PSIsContainer -eq $false) {

        Write-Host "https://storage.yandexcloud.net/public-media/$local_path"
        # Загрузите файл с сервера, перезаписав заглушку
        Invoke-WebRequest -Uri "https://storage.yandexcloud.net/public-media/berloga-biogame/$local_path" -OutFile $full_path
    }
}