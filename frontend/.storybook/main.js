/** @type { import('@storybook/vue3-vite').StorybookConfig } */
import AutoImportFunctions from "unplugin-auto-import/vite"
import AutoImportComponents from "unplugin-vue-components/vite";

const config = {
  async viteFinal(config) {
    if (config.plugins) {
      config.plugins.push(
        AutoImportFunctions ({ imports: ["vue"], dts: ".storybook/auto-imports.d.ts" })
      );
    }
    config.plugins.push(
      AutoImportComponents({
        dirs: ["components"],
        dts: ".storybook/components.d.ts",
      })
    );
    return {
      ...config,
      define: {
        ...config.define,
        global: "window",
      },
    };
  },
  stories: [
    "../stories/**/*.mdx",
    "../stories/**/*.stories.@(js|jsx|mjs|ts|tsx)",
    "../components/stories/**/*.stories.@(js|jsx|ts|tsx)"
  ],
  addons: [
    "@storybook/addon-links",
    "@storybook/addon-essentials",
    "@storybook/addon-interactions",
    "@storybook/addon-controls",
    "@storybook/addon-actions"
  ],
  framework: {
    name: "@storybook/vue3-vite",
    options: {},
  },
  docs: {
    autodocs: "tag",
  },
};
export default config;
