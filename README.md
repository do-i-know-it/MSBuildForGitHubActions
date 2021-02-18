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

## Future works

- Writes README.md completely.
- Writes how to set up configuration for another repository.
