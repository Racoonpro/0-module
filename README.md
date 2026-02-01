### Powershell

Script to create direcotry for the project.

```
$root = "raccoonpro-school";
$dirs = @(
  "$root/module-0/01-beginner-console",
  "$root/module-0/02-intermediate-refactor",
  "$root/module-0/03-webapi-glimpse",
  "$root/shared/docs",
  "$root/shared/scripts"
);
New-Item -ItemType Directory -Path $dirs -Force | Out-Null;
New-Item -ItemType File -Path "$root/README.md" -Force | Out-Null;
```
