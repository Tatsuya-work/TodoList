import type { Meta, StoryObj } from "@storybook/vue3";
import categoryTab from "../categoryTab.vue";

const meta: Meta<typeof categoryTab> = {
  title: "components/categoryTab",
  component: categoryTab,
  render: (args) => ({
    components: { categoryTab },
    tags: ["autodocs"],
    setup() {
      return { args };
    },
    template: '<categoryTab v-bind="args" />',
    parameters: { actions: { argTypesRegex: "^on.*" } }
  })
};

export default meta;

export const Default = {};
export const Pattern1: StoryObj = {
  args: {
    categorys: ["Work", "Study", "Sports"]
  }
};
