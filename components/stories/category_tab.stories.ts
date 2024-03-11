import type { Meta, StoryObj } from "@storybook/vue3";
import category_tab from "../category_tab.vue";

const meta: Meta<typeof category_tab> = {
    title: "components/category_tab",
    component: category_tab,
    render: (args) => ({
        components: { category_tab },
        tags: ["autodocs"],
        setup() {
            return { args };
        },
        template: '<category_tab v-bind="args" />',
        parameters: { actions: { argTypesRegex: '^on.*' } },
    }),
};

export default meta;

export const Default = {};
export const Pattern1: StoryObj = {
    args: {
        items: ['Work', 'Study', 'Sports'],
    }
};