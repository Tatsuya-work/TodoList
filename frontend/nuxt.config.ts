// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  devtools: { enabled: true },

  css: ["~/assets/css/global.css", "~/assets/css/reset.css"],
  components: [
    {
      path: "@/components",
      pathPrefix: false
    }
  ],
  runtimeConfig: {
    public: {
      apiBase: ""
    }
  }
});
