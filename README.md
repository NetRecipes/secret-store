# Secret Store

`.NET Aspire` + `DAPR` - Secret Store

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
