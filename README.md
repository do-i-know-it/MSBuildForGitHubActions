# MSBuildSampleForGitHubActions

This repository is example for [GitHub Actions](https://github.co.jp/features/actions) using msbuild.

## Environments

- Windows 10
- .NET
- MSBuild

## Usage

```yaml
jobs:
  construction:
    runs-on: windows-2019
    steps:
        run : |
            dotnet msbuild %BUILD_FILE_PATH% -p:^
            InputPath=%INPUT_PATH%^
            ;OutputPath=%OUTPUT_PATH%^
            ;Configuration=%CONFIGURATION%^
```

Developers can use this action files to

- develop
- assess
- deploy

applications, by defining

- `BUILD_FILE_PATH`
- `INPOUT_PATH`
- `OUTPUT_PATH`
- `CONFIGURATION`

in [GitHub Actions](https://github.co.jp/features/actions), and changing

- `EntryPointFilePath`
- `MajorVersion`
- `MinorVersion`
- `Revision`
- `BuildNumber`

in `build.xml`.

## Future works

- Adds templates.
  - pull request

## License

This repository is under the [MIT License](https://opensource.org/licenses/mit-license.php), see [LICENSE](./LICENSE.txt).
