# Secret Store

`.NET Aspire` + `DAPR` - Secret Store

## For a written article, refer: [Secrets](https://netrecipes.github.io/courses/dapr-aspire/secrets/)

- [x] `Local JSON` file

```yaml
apiVersion: dapr.io/v1alpha1
kind: Component
metadata:
  name: secretstore
  namespace: default
spec:
  type: secretstores.local.file
  version: v1
  metadata:
    - name: secretsFile
      value: ../SecretsStore/secrets.json
    - name: nestedSeparator
      value: ":"
```

---

- [x] `Local Environment Variables`

```yaml
apiVersion: dapr.io/v1alpha1
kind: Component
metadata:
  name: secretstore
  namespace: default
spec:
  type: secretstores.local.env
  version: v1
  metadata:
```

---
