import type { Meta, StoryObj } from "@storybook/vue3";
import addTaskTab from "../addTaskTab.vue";

const meta: Meta<typeof addTaskTab> = {
  title: "components/addTaskTab",
  component: addTaskTab,
  render: (args) => ({
    components: { addTaskTab },
    tags: ["autodocs"],
    setup() {
      return { args };
    },
    template: '<addTaskTab v-bind="args" />',
    parameters: { actions: { argTypesRegex: "^on.*" } }
  })
};

export default meta;

export const Default = {};
export const Pattern1: StoryObj = {
  args: {
    category: "Work"
  }
};
