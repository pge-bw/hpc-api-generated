Generation commands:
 - npm i -g autorest@previous (we need 2 autorest version)
 - hpcpack.yml from here: https://github.com/Azure/hpcpack-rest-api-spec/blob/2019/src/hpcpack.yaml
 - autorest --debug --csharp --input-file="/tmp/hpc_api/hpcpack.yml" --output-folder="/tmp/hpc_api" --namespace=Microsoft.Hpc.Rest --add-credentials --override-client-name=HPCPackRestClient
